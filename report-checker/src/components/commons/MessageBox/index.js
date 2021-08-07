import React from 'react'
import { Container, Wrapper } from './elements'

const MessageBox = ({ width, arrowPosition = 'left', children }) => {
  return (
    <Container width={width}>
      <Wrapper arrowPosition={arrowPosition}>{children}</Wrapper>
    </Container>
  )
}

export default MessageBox
