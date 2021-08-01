import React, { useState, useEffect } from 'react'
import { Wrapper } from './elements'
import ButtonNormal from '../ButtonNormal'

const RadioButton = ({ data = [], size = 'small', width, valueOnChange }) => {
  const buttonWidth = `${100 / data.length}%`
  const [value, setValue] = useState(data[0].value)

  const clickHandle = val => {
    setValue(prev => (prev = val))
  }

  useEffect(() => {
    valueOnChange?.(value)
  }, [value, valueOnChange])

  return (
    <Wrapper width={width}>
      {data?.map((item, index) => (
        <ButtonNormal
          key={index}
          text={item.name}
          size={size}
          width={buttonWidth}
          active={item.value === value}
          onClick={() => clickHandle(item.value)}
        />
      ))}
    </Wrapper>
  )
}

export default RadioButton
