import React, { useState, useEffect } from 'react'
import { Params } from './defaultValue'
import {
  Wrapper,
  ContentLeft,
  ContentRight,
  SearchBar,
  SearchResult,
  Instance,
  Header,
  InfoArea,
  ItemName,
  DateWrapper,
  Body,
  Table,
  TableHeader,
  Row,
  ColumnTitle,
  TableBody,
  Column
} from './elements'
import LoadingLocal from './../../../components/commons/LoadingLocal/index'
import InputText from './../../../components/commons/InputText/index'
import AppLogo from './../../../components/commons/AppLogo/index'
import dataApi from '../../../api/dataApi'

const sortData = (data = []) => {
  return [...data].sort((a, b) => String(a).localeCompare(b))
}

const splitString = str => {
  return str.split(/[\s,]+/)
}

const removeAccents = str => {
  return str
    .normalize('NFD')
    .replace(/[\u0300-\u036f]/g, '')
    .replace(/đ/g, 'd')
    .replace(/Đ/g, 'D')
}

const checkContains = (target, pattern) => {
  var value = 0
  pattern.forEach(word => {
    value = value + target.includes(word)
  })
  return value === pattern.length
}

const fullDate = () => {
  const separator = ' - '
  const myCurrentDate = new Date()
  const date = myCurrentDate.getDate()
  const month = myCurrentDate.getMonth() + 1
  const year = myCurrentDate.getFullYear()

  return `${date}${separator}${
    month < 10 ? `0${month}` : `${month}`
  }${separator}${year}`
}

const AnalystDetail = () => {
  const [listName, setNameList] = useState([])
  const [nameSearch, setNameSearch] = useState('')
  const [dataTable, setDataTable] = useState([])

  useEffect(() => {
    dataApi.getAllNameOfItems().then(response => {
      setNameList(prev => (prev = sortData(response)))
    })
  }, [])

  const instanceOnClickHandle = value => {
    dataApi
      .getItemDetailByName({ name: listName[value] })
      .then(response => setDataTable(prev => (prev = response)))
  }

  return (
    <Wrapper>
      <ContentLeft>
        <SearchBar>
          <InputText
            placeholder='Tìm kiếm tại đây...'
            width='100%'
            size={Params.InputText.size}
            value={nameSearch}
            onChange={e => setNameSearch(prev => (prev = e.target.value))}
          />
        </SearchBar>
        <SearchResult>
          {listName.length ? (
            listName.map((name, index) =>
              checkContains(
                removeAccents(name.toLowerCase()),
                splitString(removeAccents(nameSearch.toLowerCase()))
              ) ? (
                <Instance
                  key={index}
                  onClick={() => instanceOnClickHandle(index)}
                  isSelected={dataTable?.[0]?.[0] === name}
                >
                  {name}
                </Instance>
              ) : null
            )
          ) : (
            <LoadingLocal />
          )}
        </SearchResult>
      </ContentLeft>
      <ContentRight>
        <Header>
          <InfoArea>
            <ItemName>{dataTable?.[0]?.[0]}</ItemName>
            <DateWrapper>{fullDate()}</DateWrapper>
          </InfoArea>
          <AppLogo size={Params.AppLogo.size} />
        </Header>
        <hr />
        <Body>
          <Table
            width='100%'
            height='100%'
            columnWidth={Params.TableHeader.map(item => item.width)}
          >
            <TableHeader>
              <Row>
                {Params.TableHeader.map((item, index) => (
                  <ColumnTitle key={index}>{item.name}</ColumnTitle>
                ))}
              </Row>
            </TableHeader>
            <TableBody>
              {dataTable.map((item, index) => (
                <Row key={index}>
                  <Column style={{ textAlign: 'center' }}>{index + 1}</Column>
                  <Column>{item[1]}</Column>
                  <Column>{item[2]}</Column>
                  <Column style={{ textAlign: 'right' }}>{item[3]}</Column>
                  <Column style={{ textAlign: 'right' }}>{item[4]}</Column>
                  <Column style={{ textAlign: 'right' }}>{item[5]}</Column>
                  <Column style={{ textAlign: 'right' }}>{item[6]}</Column>
                </Row>
              ))}
            </TableBody>
          </Table>
        </Body>
      </ContentRight>
    </Wrapper>
  )
}

export default AnalystDetail
