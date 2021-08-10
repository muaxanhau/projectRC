import React from 'react'
import Images from './../../../constants/Images'
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
  Date,
  Body
} from './elements'
import InputText from './../../../components/commons/InputText/index'
import ButtonIcon from './../../../components/commons/ButtonIcon/index'
import AppLogo from './../../../components/commons/AppLogo/index'

const AnalystDetail = () => {
  return (
    <Wrapper>
      <ContentLeft>
        <SearchBar>
          <InputText
            placeholder='Tìm kiếm tại đây...'
            width='100%'
            size='small'
          />
          <ButtonIcon icon={Images.SEARCH_ICON} size='small' />
        </SearchBar>
        <SearchResult>
          <Instance>Áo thun</Instance>
          <Instance>Áo thun</Instance>
          <Instance>Áo thun</Instance>
          <Instance>Áo thun</Instance>
          <Instance>Áo thun</Instance>
          <Instance>Áo thun</Instance>
          <Instance>Áo thun</Instance>
          <Instance>Áo thun</Instance>
          <Instance>Áo thun</Instance>
          <Instance>Áo thun</Instance>
          <Instance>Áo thun</Instance>
          <Instance>Áo thun</Instance>
          <Instance>Áo thun</Instance>
          <Instance>Áo thun</Instance>
          <Instance>Áo thun</Instance>
          <Instance>Áo thun</Instance>
          <Instance>Áo thun</Instance>
          <Instance>Áo thun</Instance>
        </SearchResult>
      </ContentLeft>
      <ContentRight>
        <Header>
          <InfoArea>
            <ItemName>Áo thun</ItemName>
            <Date>22/08/2021</Date>
          </InfoArea>
          <AppLogo size='medium' />
        </Header>
        <hr />
        <Body>
          <p>ahihi</p>
        </Body>
      </ContentRight>
    </Wrapper>
  )
}

export default AnalystDetail
