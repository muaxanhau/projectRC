import React, { useState, useEffect } from 'react'
import { Range } from './elements'

const RangeSliders = ({
  width,
  min = 0,
  max = 100,
  value = 50,
  enableTooltip,
  unit,
  onChangeHandle
}) => {
  const [localValue, setLocalValue] = useState(value)

  useEffect(() => {
    onChangeHandle?.(localValue)
  }, [onChangeHandle, localValue])

  useEffect(() => {
    setLocalValue(prev => (prev = value))
  }, [value])

  return (
    <Range
      width={width}
      type='range'
      min={min}
      max={max}
      value={localValue}
      enableTooltip={enableTooltip}
      tooltip={localValue + unit}
      onChange={e => setLocalValue(prev => (prev = e.target.value))}
    />
  )
}

export default RangeSliders
