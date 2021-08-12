import React, { useState, useEffect } from 'react'
import Images from '../../../constants/Images'
import { Params } from './defaultValue'
import {
  Table,
  Header,
  Body,
  Row,
  ColumnTitle,
  SortIcon,
  Column,
  StatusIcon
} from './elements'
import LoadingLocal from './../../../components/commons/LoadingLocal/index'
import dataApi from './../../../api/dataApi'

const imagesArr = [
  Images.ARROW_DOWN_ICON,
  Images.ARROW_DOWN_RIGHT_ICON,
  Images.ARROW_BALANCE_ICON,
  Images.ARROW_UP_RIGHT_ICON,
  Images.ARROW_UP_ICON
]

const sortData = (data = [], position, condition = -1) => {
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
    dataApi.getAllItemsAndDetails().then(response => {
      setDataTable(prev => (prev = response))
      setSortStatus(prev => (prev = 0))
    })
  }, [])

  useEffect(() => {
    setCondition(prev => (prev = -1))
  }, [sortStatus])

  useEffect(() => {
    setDataTable(prev => (prev = sortData(dataTable, sortStatus, condition)))
  }, [sortStatus, condition])

  return dataTable.length ? (
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
            <Column>{parseInt(item[2]) === -1 ? '-' : item[2]}</Column>
            <Column>{parseInt(item[3]) === -1 ? '-' : item[3]}</Column>
            <Column>{parseInt(item[4]) === -1 ? '-' : item[4]}</Column>
            <Column>
              {parseInt(item[5]) === -1 ? (
                '-'
              ) : (
                <StatusIcon src={imagesArr[item[5] - 1]} />
              )}
            </Column>
          </Row>
        ))}
      </Body>
    </Table>
  ) : (
    <LoadingLocal />
  )
}

export default AnalystAll
