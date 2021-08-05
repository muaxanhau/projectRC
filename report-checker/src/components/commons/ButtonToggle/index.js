import React, { useState, useEffect } from 'react'
import { Wrapper, Circle } from './elements'

const ButtonToggle = ({
  size,
  icon1,
  icon2,
  isLeft = true,
  tooltip,
  onClickHandle
}) => {
  const [icon, setIcon] = useState(icon1)

  useEffect(() => {
    setIcon(prev => (prev = isLeft ? icon1 : icon2))
  }, [isLeft, icon1, icon2])

  return (
    <Wrapper size={size} tooltip={tooltip} onClick={() => onClickHandle?.()}>
      <Circle icon={icon} isOne={isLeft} />
    </Wrapper>
  )
}

export default ButtonToggle
