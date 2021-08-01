import React, { useState, useEffect } from 'react'
import { Params } from './defaultValue'
import {
  Table,
  Header,
  Body,
  Row,
  ColumnTitle,
  Column,
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

const DataTable = ({
  data = [],
  width,
  height,
  editable = false,
  onDataChange
}) => {
  const [dataRef, setDataRef] = useState([...data])

  useEffect(() => {
    onDataChange?.(dataRef)
  }, [dataRef])

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
              <ColumnTitle key={index}>{item.name}</ColumnTitle>
            ))}
          </Row>
        </Header>
        <Body>
          {data.map((item, itemIndex) =>
            item.colors.map((color, colorIndex) =>
              color.sizes.map((size, sizeIndex) => (
                <Row key={'i' + itemIndex + 'c' + colorIndex + 's' + sizeIndex}>
                  <Column>
                    {colorIndex === 0 && sizeIndex === 0 && itemIndex + 1}
                  </Column>
                  <Column>
                    {colorIndex === 0 && sizeIndex === 0 && item.name}
                  </Column>
                  <Column>{sizeIndex === 0 && color.name}</Column>
                  <Column>{size.name}</Column>
                  <Column>{size.quantity}</Column>
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
            <ColumnTitle key={index}>{item.name}</ColumnTitle>
          ))}
        </Row>
      </Header>
      <Body>
        {dataRef.map((item, itemIndex) =>
          item.colors.map((color, colorIndex) =>
            color.sizes.map((size, sizeIndex) =>
              editable ? (
                <Row key={'i' + itemIndex + 'c' + colorIndex + 's' + sizeIndex}>
                  <Column>
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
                  <Column>
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
              ) : (
                <Row key={'i' + itemIndex + 'c' + colorIndex + 's' + sizeIndex}>
                  <Column>
                    {colorIndex === 0 && sizeIndex === 0 && itemIndex + 1}
                  </Column>
                  <Column>
                    {colorIndex === 0 && sizeIndex === 0 && item.name}
                  </Column>
                  <Column>{sizeIndex === 0 && color.name}</Column>
                  <Column>{size.name}</Column>
                  <Column>{size.quantity}</Column>
                </Row>
              )
            )
          )
        )}
      </Body>
    </Table>
  )
}

export default DataTable
