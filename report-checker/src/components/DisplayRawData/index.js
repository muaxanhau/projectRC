import React, { useState } from 'react'
import { Params } from './defaultValue'
import { Wrapper } from './elements'
import FormLayout from './../commons/ui/FormLayout/index'
import InputTextarea from '../commons/InputTextarea/index'
import DataTable from '../commons/DataTable/index'
import { useDispatch } from 'react-redux'
import { alertOn } from './../../features/Alert/alertSlice'

const isSomethingNull = (dataTable = []) =>
  dataTable
    .map(item => {
      if (item.name.trim() === '' || item.name === null) return true
      return item.colors
        .map(color => {
          if (color.name.trim() === '' || color.name === null) return true
          return color.sizes
            .map(
              size =>
                size.name.trim() === '' ||
                size.name === null ||
                size.quantity === '' ||
                size.quantity === null
            )
            .some(value => value === true)
        })
        .some(value => value === true)
    })
    .some(value => value === true)

const DisplayRawData = ({
  dataRaw,
  dataTable = [],
  okHandle,
  cancelHandle
}) => {
  const [dataTemporary, setDataTemporary] = useState([])
  const dispatch = useDispatch()

  const okButtonHandle = () => {
    if (isSomethingNull(dataTemporary)) {
      dispatch(
        alertOn({
          text: 'Không bỏ trống!'
        })
      )
      return
    }
    okHandle?.(dataTemporary)
  }

  return (
    <FormLayout
      width={Params.Form.width}
      title={Params.Title.text}
      textButton1={Params.Button.name.add}
      textButton2={Params.Button.name.cancel}
      button1Handle={okButtonHandle}
      button2Handle={() => cancelHandle?.()}
    >
      <Wrapper>
        <InputTextarea
          value={dataRaw}
          onChange={() => {}}
          width={`calc(100% - ${Params.Table.width})`}
          height='auto'
        />
        <DataTable
          data={dataTable}
          width={Params.Table.width}
          height={Params.Table.height}
          editable
          onDataChange={data => setDataTemporary(prev => (prev = data))}
        />
      </Wrapper>
    </FormLayout>
  )
}

export default DisplayRawData
