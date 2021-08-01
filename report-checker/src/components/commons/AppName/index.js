import React from 'react'
import { Wrapper } from './elements'
import DefaultValues from '../../../constants/DefaultValues'

const AppName = ({ size = 'small' }) => {
  return <Wrapper size={size}>{DefaultValues.APP_NAME}</Wrapper>
}

export default AppName
