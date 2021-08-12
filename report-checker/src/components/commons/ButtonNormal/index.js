import React from 'react'
import { Button } from './elements'

const ButtonNormal = ({
  text = 'Text here',
  size = 'medium',
  width,
  active,
  ...rest
}) => {
  return (
    <Button size={size} width={width} active={active} {...rest}>
      {text}
    </Button>
  )
}

export default ButtonNormal
