import React, { useState } from 'react'
import { Params } from './defaultValue'
import { Wrapper, Option } from './elements'
import FormLayout from './../../components/commons/ui/FormLayout/index'
import { useDispatch, useSelector } from 'react-redux'
import { selectDataCollection } from './../DataCollection/dataCollectionSlice'
import { loadingOn, loadingOff } from '../Loading/loadingSlice'
import { alertOn } from '../Alert/alertSlice'
import dataApi from '../../api/dataApi'
import XLSX from 'xlsx'
import { saveAs } from 'file-saver'

const convertObjectToArray = (data = []) => {
  let arrData = []
  data.forEach((item, itemIndex) =>
    item.colors.forEach((color, colorIndex) =>
      color.sizes.forEach((size, sizeIndex) => {
        let row = []
        row.push(colorIndex === 0 && sizeIndex === 0 ? itemIndex + 1 : '')
        row.push(colorIndex === 0 && sizeIndex === 0 ? item.name : '')
        row.push(sizeIndex === 0 ? color.name : '')
        row.push(size.name)
        row.push(size.quantity)
        arrData.push(row)
      })
    )
  )
  return arrData
}
const s2ab = s => {
  var buf = new ArrayBuffer(s.length) //convert s to arrayBuffer
  var view = new Uint8Array(buf) //create uint8array as viewer
  for (var i = 0; i < s.length; i++) view[i] = s.charCodeAt(i) & 0xff //convert to octet
  return buf
}
const createExcel = (data = []) => {
  const date = new Date()
  var wb = XLSX.utils.book_new()
  wb.Props = {
    Title: 'ReportChecker',
    Subject: 'ReportChecker',
    Author: 'ReportChecker',
    CreatedDate: new Date(date.getFullYear(), date.getMonth(), date.getDay())
  }
  wb.SheetNames.push('Sheet')

  var ws_data = convertObjectToArray(data)

  var ws = XLSX.utils.aoa_to_sheet(ws_data)

  wb.Sheets['Sheet'] = ws

  const extension = 'xlsx'
  var wbout = XLSX.write(wb, { bookType: extension, type: 'binary' })

  const nameFile =
    date.getHours() +
    '-' +
    date.getMinutes() +
    '-' +
    date.getSeconds() +
    '_' +
    date.getDate() +
    '-' +
    (date.getMonth() + 1) +
    '-' +
    date.getFullYear() +
    '.' +
    extension

  saveAs(
    new Blob([s2ab(wbout)], { type: 'application/octet-stream' }),
    nameFile
  )
}

const StoreData = ({ okHandle, cancelHandle }) => {
  const dispatch = useDispatch()
  const dataCollection = useSelector(selectDataCollection)
  const [isCreateExcel, setIsCreateExcel] = useState(true)
  const [isStoreDatabase, setIsStoreDatabase] = useState(true)
  const storeButtonHandle = () => {
    dispatch(loadingOn({ text: 'Đang lưu' }))

    const createExcelPromise = new Promise((resolve, reject) => {
      if (!isCreateExcel) {
        return resolve(false)
      }
      try {
        createExcel(dataCollection.itemTotals)
        return resolve(true)
      } catch (error) {
        return reject(false)
      }
    })

    const storeDBPromise = new Promise((resolve, reject) => {
      if (!isStoreDatabase) {
        return resolve(false)
      }

      dataApi
        .store({ items: dataCollection.itemTotals })
        .then(response => resolve(true))
        .catch(error => reject(false))
    })

    Promise.all([createExcelPromise, storeDBPromise])
      .then(result => {
        if (result.some(item => item === true)) {
          dispatch(alertOn({ text: 'Lưu thành công' }))
        }
      })
      .catch(error => {
        dispatch(alertOn({ text: 'Không thành công' }))
      })
      .finally(() => {
        dispatch(loadingOff())
        okHandle?.()
      })
  }
  const cancelButtonHandle = () => {
    cancelHandle?.()
  }

  return (
    <FormLayout
      width={Params.Form.width}
      title={Params.Title.text}
      textButton1={Params.Button.name.store}
      textButton2={Params.Button.name.cancel}
      button1Handle={storeButtonHandle}
      button2Handle={cancelButtonHandle}
    >
      <Wrapper>
        <Option>
          <input
            type='checkbox'
            id='create-excel'
            defaultChecked={isCreateExcel}
            onClick={() => {
              setIsCreateExcel(prev => (prev = !prev))
            }}
          />
          <label htmlFor='create-excel'>Tạo file Excel.</label>
        </Option>
        <Option>
          <input
            type='checkbox'
            id='store-database'
            defaultChecked={isStoreDatabase}
            onClick={() => {
              setIsStoreDatabase(prev => (prev = !prev))
            }}
          />
          <label htmlFor='store-database'>Lưu về máy chủ.</label>
        </Option>
      </Wrapper>
    </FormLayout>
  )
}

export default StoreData
