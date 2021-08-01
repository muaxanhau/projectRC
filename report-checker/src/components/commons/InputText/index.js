import React from 'react'
import { Wrapper } from './elements'

const InputText = React.forwardRef(
  ({ icon, size = 'medium', width, ...rest }, ref) => {
    return (
      <Wrapper icon={icon} size={size} width={width}>
        <input ref={ref} {...rest} />
      </Wrapper>
    )
  }
)

export default InputText
