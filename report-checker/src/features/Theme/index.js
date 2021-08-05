import React, { useEffect } from 'react'
import { ThemeDark, ThemeLight } from './elements'
import { useSelector, useDispatch } from 'react-redux'
import { selectTheme, toggleTheme } from './themeSlice'

const Theme = () => {
  const theme = useSelector(selectTheme)
  const dispatch = useDispatch()

  useEffect(() => {
    const themeLocalStorage = localStorage.getItem('theme')
    themeLocalStorage === 'dark' &&
      theme.isLightTheme &&
      dispatch(toggleTheme())
  }, [])

  return theme.isLightTheme ? <ThemeLight /> : <ThemeDark />
}

export default Theme
