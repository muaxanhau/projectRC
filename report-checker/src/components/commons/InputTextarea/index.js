import React from 'react'
import { Textarea } from './elements'

const InputTextarea = React.forwardRef(({ width, height, ...rest }, ref) => {
  return (
    <Textarea
      ref={ref}
      width={width}
      height={height}
      {...rest}
      spellCheck='false'
    />
  )
})

export default InputTextarea
