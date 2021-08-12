import React from 'react'
import { Wrapper } from './element'

const Title = ({ text = 'Text here', size = 'medium', type = 'dark' }) => {
  return (
    <Wrapper size={size} type={type}>
      {text}
    </Wrapper>
  )
}

export default Title
