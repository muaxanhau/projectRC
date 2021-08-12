import React from 'react'
import { Params } from './defaultValue'
import { Text } from './elements'
import FormLayout from './../../components/commons/ui/FormLayout/index'
import { useSelector, useDispatch } from 'react-redux'
import { alertOff, selectAlert } from './alertSlice'

const Alert = () => {
  const alert = useSelector(selectAlert)
  const dispatch = useDispatch()

  const okButtonHandle = () => {
    dispatch(alertOff())
    alert.okHandle?.()
  }
  const cancelButtonHandle = () => {
    dispatch(alertOff())
    alert.cancelHandle?.()
  }

  if (!alert.isOn) return null
  return (
    <FormLayout
      width={Params.Form.width}
      textButton1={Params.Button.name.ok}
      textButton2={Params.Button.name.cancel}
      button1Handle={okButtonHandle}
      button2Handle={cancelButtonHandle}
    >
      <Text>{alert.text}</Text>
    </FormLayout>
  )
}

export default Alert
