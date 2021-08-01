import React, { useState } from 'react'
import { Params } from './defaultValue'
import {
  Wrapper,
  ContentLeft,
  ControlLeftArea,
  ContentRight,
  ControlRightArea
} from './elements'
import ButtonNormal from './../commons/ButtonNormal/index'
import ButtonIcon from './../commons/ButtonIcon/index'
import Title from './../commons/Title/index'
import RadioButton from './../commons/RadioButton/index'
import InputTextarea from './../commons/InputTextarea/index'
import DataTable from './../commons/DataTable/index'
import DisplayRawData from './../DisplayRawData/index'
import { useDispatch, useSelector } from 'react-redux'
import { loadingOn, loadingOff } from './../../features/Loading/loadingSlice'
import { alertOn } from './../../features/Alert/alertSlice'
import {
  addDataToItemTotals,
  clearItemTotals,
  undoItemTotals,
  redoItemTotals,
  selectDataCollection
} from './../../features/DataCollection/dataCollectionSlice'
import dataApi from './../../api/dataApi'

const Checker = () => {
  const dispatch = useDispatch()
  const dataCollection = useSelector(selectDataCollection)
  const [option, setOption] = useState()
  const [rawData, setRawData] = useState('')
  const [temporaryData, setTemporaryData] = useState([])
  const [isDisplayTemporaryData, setIsDisplayTemporaryData] = useState(false)

  const transformDataButtonHandle = () => {
    if (rawData.trim() === '' || rawData === null) {
      dispatch(alertOn({ text: 'Trống' }))
      return
    }

    dispatch(loadingOn({ text: 'Đang xử lí' }))
    dataApi
      .transform({ purestring: rawData, option: option })
      .then(respone => {
        setTemporaryData(prev => (prev = respone))
        setIsDisplayTemporaryData(prev => (prev = true))
      })
      .catch(e => dispatch(alertOn({ text: 'Không thành công' })))
      .finally(() => dispatch(loadingOff()))
  }
  const deleteRawDataButtonHandle = () => {
    setRawData(prev => (prev = ''))
  }
  const undoButtonHandle = () => {
    dispatch(undoItemTotals())
  }
  const redoButtonHandle = () => {
    dispatch(redoItemTotals())
  }
  const clearDataButtonHandle = () => {
    dispatch(clearItemTotals())
  }
  const storeDataButtonHandle = () => {
    if (!dataCollection.itemTotals.length) {
      dispatch(alertOn({ text: 'Trống' }))
      return
    }

    dispatch(loadingOn({ text: 'Đang lưu' }))
    dataApi
      .store({ items: dataCollection.itemTotals })
      .then(response => dispatch(alertOn({ text: 'Lưu thành công' })))
      .catch(e => dispatch(alertOn({ text: 'Không thành công' })))
      .finally(() => dispatch(loadingOff()))
  }

  const okButtonDisplayTemporaryData = data => {
    setTemporaryData(prev => {
      prev = data
      dispatch(addDataToItemTotals({ items: prev }))
      return prev
    })

    setIsDisplayTemporaryData(prev => (prev = false))
  }
  const cancelButtonDisplayTemporaryData = () => {
    setIsDisplayTemporaryData(prev => (prev = false))
  }

  return (
    <>
      {isDisplayTemporaryData && (
        <DisplayRawData
          dataRaw={rawData}
          dataTable={temporaryData}
          okHandle={okButtonDisplayTemporaryData}
          cancelHandle={cancelButtonDisplayTemporaryData}
        />
      )}
      <Wrapper>
        <ContentLeft>
          <Title text={Params.Title.name.left} size={Params.Title.size} />
          <RadioButton
            data={Params.RadioButton.data}
            size={Params.ButtonNormal.size}
            width='100%'
            valueOnChange={val => {
              setOption(prev => (prev = val))
            }}
          />
          <InputTextarea
            width='100%'
            height={Params.InputTextarea.height}
            value={rawData}
            onChange={p => setRawData(prev => (prev = p.target.value))}
          />
          <ControlLeftArea>
            <ButtonNormal
              text={Params.ButtonNormal.name.transform}
              size={Params.ButtonNormal.size}
              width='70%'
              onClick={transformDataButtonHandle}
            />
            <ButtonNormal
              text={Params.ButtonNormal.name.clear}
              size={Params.ButtonNormal.size}
              width='30%'
              onClick={deleteRawDataButtonHandle}
            />
          </ControlLeftArea>
        </ContentLeft>
        <ContentRight>
          <Title text={Params.Title.name.right} size={Params.Title.size} />
          <DataTable
            data={dataCollection.itemTotals}
            width='100%'
            height={Params.Table.height}
          />
          <ControlRightArea>
            <ButtonIcon
              size={Params.ButtonIcon.size}
              icon={Params.ButtonIcon.undo.icon.normal}
              iconSelected={Params.ButtonIcon.undo.icon.selected}
              tooltip={Params.ButtonIcon.undo.tooltip}
              onClick={undoButtonHandle}
            />
            <ButtonIcon
              size={Params.ButtonIcon.size}
              icon={Params.ButtonIcon.redo.icon.normal}
              iconSelected={Params.ButtonIcon.redo.icon.selected}
              tooltip={Params.ButtonIcon.redo.tooltip}
              onClick={redoButtonHandle}
            />
            <ButtonNormal
              text={Params.ButtonNormal.name.clear}
              size={Params.ButtonNormal.size}
              onClick={clearDataButtonHandle}
            />
          </ControlRightArea>
          <ButtonNormal
            text={Params.ButtonNormal.name.store}
            size={Params.ButtonNormal.size}
            width='100%'
            onClick={storeDataButtonHandle}
          />
        </ContentRight>
      </Wrapper>
    </>
  )
}

export default Checker
