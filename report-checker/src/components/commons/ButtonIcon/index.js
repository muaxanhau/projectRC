import React from 'react'
import { Button } from './elements'

const ButtonIcon = ({
  size = 'small',
  icon,
  iconSelected,
  tooltip,
  ...rest
}) => {
  return (
    <Button
      size={size}
      icon={icon}
      iconSelected={iconSelected}
      tooltip={tooltip}
      {...rest}
    />
  )
}

export default ButtonIcon
