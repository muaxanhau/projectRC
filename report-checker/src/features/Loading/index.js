import React from 'react'
import { Container, Wrapper, Type1, Type2 } from './elements'
import { useSelector } from 'react-redux'
import { selectLoading } from './loadingSlice'

const Loading = () => {
  const loading = useSelector(selectLoading)

  if (!loading.isOn) return null
  return (
    <Container>
      <Wrapper>
        <Type1 text={loading.text} />
        <Type2 text={loading.text} />
      </Wrapper>
    </Container>
  )
}

export default Loading
