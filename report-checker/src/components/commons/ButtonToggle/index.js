import React, { useState, useEffect } from 'react'
import { Wrapper, Circle } from './elements'
import { useSelector } from 'react-redux'
import { selectTheme } from '../../../features/Theme/themeSlice'

const ButtonToggle = ({ size, icon1, icon2, onClickHandle }) => {
  const theme = useSelector(selectTheme)
  const [isOne, setIsOne] = useState(theme.isLightTheme)
  const [icon, setIcon] = useState(icon1)
  const toggleButtonHandle = () => {
    setIsOne(prev => (prev = !prev))
    onClickHandle?.()
  }
  useEffect(() => {
    setIcon(prev => (prev = isOne ? icon1 : icon2))
  }, [isOne, icon1, icon2])
  return (
    <Wrapper size={size} onClick={toggleButtonHandle}>
      <Circle icon={icon} isOne={isOne} />
    </Wrapper>
  )
}

export default ButtonToggle
