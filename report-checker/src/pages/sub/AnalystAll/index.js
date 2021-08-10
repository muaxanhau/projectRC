import React, { useState, useEffect } from 'react'
import Images from '../../../constants/Images'
import { Params, tableFakeData } from './defaultValue'
import {
  Table,
  Header,
  Body,
  Row,
  ColumnTitle,
  SortIcon,
  Column
} from './elements'

const sortData = (data = [], position, condition) => {
  return position
    ? [...data].sort((a, b) => (a[position] - b[position]) * condition)
    : [...data].sort(
        (a, b) => String(a[position]).localeCompare(b[position]) * -condition
      )
}

const AnalystAll = () => {
  const [dataTable, setDataTable] = useState([])
  const [sortStatus, setSortStatus] = useState(-1)
  const [condition, setCondition] = useState(-1)

  useEffect(() => {
    setTimeout(() => {
      const fakeData = new Promise((resolve, reject) => {
        setDataTable(prev => (prev = tableFakeData))
        resolve()
      })
      fakeData.finally(() => {
        setSortStatus(prev => (prev = 0))
      })
    }, 0)
  }, [])

  useEffect(() => {
    setCondition(prev => (prev = -1))
  }, [sortStatus])

  useEffect(() => {
    setDataTable(prev => (prev = sortData(dataTable, sortStatus, condition)))
  }, [sortStatus, condition])

  return (
    <Table columnWidth={Params.TableHeader.map(item => item.width)}>
      <Header>
        <Row>
          {Params.TableHeader.map((item, index) => (
            <ColumnTitle
              key={index}
              tooltip={item.tooltip}
              onClick={
                index > 0
                  ? () => {
                      setSortStatus(prev => (prev = index - 1))
                      setCondition(prev => (prev = -prev))
                    }
                  : null
              }
            >
              {item.name}
              {index > 0 && sortStatus === index - 1 && (
                <SortIcon
                  src={
                    condition > 0 ? Images.SORT_UP_ICON : Images.SORT_DOWN_ICON
                  }
                />
              )}
            </ColumnTitle>
          ))}
        </Row>
      </Header>
      <Body>
        {dataTable.map((item, index) => (
          <Row key={index}>
            <Column>{index + 1}</Column>
            <Column style={{ textAlign: 'left' }}>{item[0]}</Column>
            <Column>{item[1]}</Column>
            <Column>{item[2]}</Column>
            <Column>{item[3]}</Column>
            <Column>{item[4]}</Column>
            <Column>{item[5]}</Column>
          </Row>
        ))}
      </Body>
    </Table>
  )
}

export default AnalystAll
