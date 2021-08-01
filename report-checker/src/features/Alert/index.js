import React from 'react'
import { Params } from './defaultValue'
import { Container, Wrapper, Content, Text } from './elements'
import ButtonNormal from '../../components/commons/ButtonNormal/index'
import { useSelector, useDispatch } from 'react-redux'
import { alertOff, selectAlert } from './alertSlice'

const Alert = () => {
  const alert = useSelector(selectAlert)
  const dispatch = useDispatch()

  if (!alert.isOn) return null
  return (
    <Container
      onClick={e => {
        e.preventDefault()
        if (e.target === e.currentTarget) {
          dispatch(alertOff())
          alert.cancelHandle?.()
        }
      }}
    >
      <Wrapper>
        <Content>
          <Text>{alert.text}</Text>
        </Content>
        <ButtonNormal
          text={Params.Button.name.ok}
          size={Params.Button.size}
          width={Params.Button.width}
          onClick={() => {
            dispatch(alertOff())
            alert.okHandle?.()
          }}
        />
        <ButtonNormal
          text={Params.Button.name.cancel}
          size={Params.Button.size}
          width={Params.Button.width}
          onClick={() => {
            dispatch(alertOff())
            alert.cancelHandle?.()
          }}
        />
      </Wrapper>
    </Container>
  )
}

export default Alert
