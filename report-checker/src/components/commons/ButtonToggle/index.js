import React, { useState, useEffect } from 'react'
import { Wrapper, Circle } from './elements'

const ButtonToggle = ({ size, icon1, icon2, isLeft = true, onClickHandle }) => {
  const [isOne, setIsOne] = useState(isLeft)
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
