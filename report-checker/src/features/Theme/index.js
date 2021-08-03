import React from 'react'
import { ThemeDark, ThemeLight } from './elements'
import { useSelector } from 'react-redux'
import { selectTheme } from './themeSlice'

const Theme = () => {
  const theme = useSelector(selectTheme)

  return theme.isLightTheme ? <ThemeLight /> : <ThemeDark />
}

export default Theme
