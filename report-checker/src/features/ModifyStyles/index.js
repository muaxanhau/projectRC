import React, { useEffect } from 'react'
import { CustomeStyles } from './elements'
import { useSelector, useDispatch } from 'react-redux'
import {
  selectModifyStyles,
  setAppSize,
  setFontSize,
  setBrightness
} from './modifyStylesSlice'

const ModifyStyles = () => {
  const modifyStyles = useSelector(selectModifyStyles)
  const dispatch = useDispatch()

  useEffect(() => {
    const appSizeLocalStorage = localStorage.getItem('appSize')
    const fontSizeLocalStorage = localStorage.getItem('fontSize')
    const brightnessLocalStorage = localStorage.getItem('brightness')
    dispatch(setAppSize(appSizeLocalStorage))
    dispatch(setFontSize(fontSizeLocalStorage))
    dispatch(setBrightness(brightnessLocalStorage))
  }, [])

  return (
    <CustomeStyles
      appSizePercent={modifyStyles.appSize / 100}
      fontSizePercent={modifyStyles.fontSize / 100}
      brightnessPercent={modifyStyles.brightness / 100}
    />
  )
}

export default ModifyStyles
