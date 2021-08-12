import React, { useState, useEffect } from 'react'
import Images from '../../../constants/Images'
import { Params } from './defaultValue'
import {
  Table,
  Header,
  Body,
  Row,
  ColumnTitle,
  Column,
  SortIcon,
  Input
} from './elements'
import ButtonIcon from './../ButtonIcon/index'

const spliceSize = (data, itemIndex, colorIndex, sizeIndex) => {
  data[itemIndex].colors[colorIndex].sizes.splice(sizeIndex, 1)
}
const spliceColor = (data, itemIndex, colorIndex) => {
  data[itemIndex].colors.splice(colorIndex, 1)
}
const spliceItem = (data, itemIndex) => {
  data[itemIndex].colors.length = 0
  data.splice(itemIndex, 1)
}

const sortDataOrderByName = (data = [], isDown = true) => {
  return [...data].sort(
    (a, b) => String(a.name).localeCompare(b.name) * (isDown ? 1 : -1)
  )
}

const DataTable = ({
  data = [],
  width,
  height,
  editable = false,
  onDataChange
}) => {
  const [dataRef, setDataRef] = useState([...data])
  const [isSortNameDown, setIsSortNameDown] = useState()

  useEffect(() => {
    editable && onDataChange?.(dataRef)
  }, [editable, onDataChange, dataRef])

  useEffect(() => {
    setDataRef(prev => {
      const dataSorted =
        isSortNameDown !== undefined &&
        sortDataOrderByName(data, isSortNameDown)
      return dataSorted || data
    })
  }, [editable, data])

  useEffect(() => {
    isSortNameDown !== undefined &&
      setDataRef(prev => (prev = sortDataOrderByName(dataRef, isSortNameDown)))
  }, [isSortNameDown])

  if (!editable) {
    return (
      <Table
        width={width}
        height={height}
        columnWidth={Params.HeaderUneditable.map(item => item.width)}
      >
        <Header>
          <Row>
            {Params.HeaderUneditable.map((item, index) => (
              <ColumnTitle
                key={index}
                style={{ cursor: index === 1 ? 'pointer' : 'default' }}
                onClick={
                  index === 1
                    ? () => {
                        setIsSortNameDown(prev => (prev = !prev))
                      }
                    : null
                }
              >
                {item.name}
                {index === 1 && isSortNameDown !== undefined && (
                  <SortIcon
                    src={
                      isSortNameDown
                        ? Images.SORT_DOWN_ICON
                        : Images.SORT_UP_ICON
                    }
                  />
                )}
              </ColumnTitle>
            ))}
          </Row>
        </Header>
        <Body>
          {dataRef.map((item, itemIndex) =>
            item.colors.map((color, colorIndex) =>
              color.sizes.map((size, sizeIndex) => (
                <Row key={'i' + itemIndex + 'c' + colorIndex + 's' + sizeIndex}>
                  <Column style={{ textAlign: 'center' }}>
                    {colorIndex === 0 && sizeIndex === 0 && itemIndex + 1}
                  </Column>
                  <Column>
                    {colorIndex === 0 && sizeIndex === 0 && item.name}
                  </Column>
                  <Column>{sizeIndex === 0 && color.name}</Column>
                  <Column>{size.name}</Column>
                  <Column style={{ textAlign: 'right' }}>
                    {size.quantity}
                  </Column>
                </Row>
              ))
            )
          )}
        </Body>
      </Table>
    )
  }

  const removeDataButtonHandle = (itemIndex, colorIndex, sizeIndex) => {
    const dataClone = [...dataRef]

    if (
      sizeIndex !== 0 ||
      dataClone[itemIndex].colors[colorIndex].sizes.length > 1
    )
      spliceSize(dataClone, itemIndex, colorIndex, sizeIndex)
    else if (dataClone[itemIndex].colors.length > 1)
      spliceColor(dataClone, itemIndex, colorIndex)
    else spliceItem(dataClone, itemIndex)

    setDataRef(prev => (prev = [...dataClone]))
  }

  return (
    <Table
      width={width}
      height={height}
      columnWidth={Params.HeaderEditable.map(item => item.width)}
    >
      <Header>
        <Row>
          {Params.HeaderEditable.map((item, index) => (
            <ColumnTitle
              key={index}
              style={{ cursor: index === 1 ? 'pointer' : 'default' }}
              onClick={
                index === 1
                  ? () => {
                      setIsSortNameDown(prev => (prev = !prev))
                    }
                  : null
              }
            >
              {item.name}
              {index === 1 && isSortNameDown !== undefined && (
                <SortIcon
                  src={
                    isSortNameDown ? Images.SORT_DOWN_ICON : Images.SORT_UP_ICON
                  }
                />
              )}
            </ColumnTitle>
          ))}
        </Row>
      </Header>
      <Body>
        {dataRef.map((item, itemIndex) =>
          item.colors.map((color, colorIndex) =>
            color.sizes.map((size, sizeIndex) => (
              <Row key={'i' + itemIndex + 'c' + colorIndex + 's' + sizeIndex}>
                <Column style={{ textAlign: 'center' }}>
                  {colorIndex === 0 && sizeIndex === 0 && itemIndex + 1}
                </Column>
                <Column>
                  {colorIndex === 0 && sizeIndex === 0 && (
                    <Input
                      type='text'
                      value={item.name}
                      onChange={e => {
                        const dataClone = [...dataRef]
                        dataClone[itemIndex].name = e.target.value
                        setDataRef(prev => (prev = [...dataClone]))
                      }}
                    />
                  )}
                </Column>
                <Column>
                  {sizeIndex === 0 && (
                    <Input
                      type='text'
                      value={color.name}
                      onChange={e => {
                        const dataClone = [...dataRef]
                        dataClone[itemIndex].colors[colorIndex].name =
                          e.target.value
                        setDataRef(prev => (prev = [...dataClone]))
                      }}
                    />
                  )}
                </Column>
                <Column>
                  <Input
                    type='text'
                    value={size.name}
                    onChange={e => {
                      const dataClone = [...dataRef]
                      dataClone[itemIndex].colors[colorIndex].sizes[
                        sizeIndex
                      ].name = e.target.value
                      setDataRef(prev => (prev = [...dataClone]))
                    }}
                  />
                </Column>
                <Column style={{ textAlign: 'right' }}>
                  <Input
                    type='number'
                    min={0}
                    value={size.quantity}
                    onChange={e => {
                      const dataClone = [...dataRef]
                      dataClone[itemIndex].colors[colorIndex].sizes[
                        sizeIndex
                      ].quantity = e.target.value
                      setDataRef(prev => (prev = [...dataClone]))
                    }}
                  />
                </Column>
                <Column noneFocus hasButton>
                  <ButtonIcon
                    size={Params.ButtonRemove.size}
                    icon={Params.ButtonRemove.icon.normal}
                    iconSelected={Params.ButtonRemove.icon.selected}
                    onClick={() =>
                      removeDataButtonHandle(itemIndex, colorIndex, sizeIndex)
                    }
                  />
                </Column>
              </Row>
            ))
          )
        )}
      </Body>
    </Table>
  )
}

export default DataTable
