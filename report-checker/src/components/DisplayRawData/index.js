import React, { useState } from 'react'
import { Params } from './defaultValue'
import { Container, Wrapper, Content, Main } from './elements'
import Title from '../commons/Title/index'
import ButtonNormal from '../commons/ButtonNormal'
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
    <Container
      onClick={e => {
        e.preventDefault()
        if (e.target === e.currentTarget) {
          cancelHandle?.()
        }
      }}
    >
      <Wrapper>
        <Content>
          <Title
            text={Params.Title.text}
            size={Params.Title.size}
            type={Params.Title.type}
          />
          <Main>
            <InputTextarea
              value={dataRaw}
              onChange={() => {}}
              width='25%'
              height='100%'
            />
            <DataTable
              data={dataTable}
              width='75%'
              height='100%'
              editable
              onDataChange={data => setDataTemporary(prev => (prev = data))}
            />
          </Main>
        </Content>
        <ButtonNormal
          text={Params.Button.name.add}
          size={Params.Button.size}
          width={Params.Button.width}
          onClick={okButtonHandle}
        />
        <ButtonNormal
          text={Params.Button.name.cancel}
          size={Params.Button.size}
          width={Params.Button.width}
          onClick={() => cancelHandle?.()}
        />
      </Wrapper>
    </Container>
  )
}

export default DisplayRawData
