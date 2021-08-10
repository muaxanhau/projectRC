import React, { useState } from 'react'
import { Params } from './defaultValue'
import {
  Container,
  Wrapper,
  RangeModifiedArea,
  TableBody,
  Item,
  Name,
  Content,
  ControlArea
} from './element'
import RangeSliders from './../../../components/commons/RangeSliders/index'
import ButtonToggle from './../../../components/commons/ButtonToggle/index'
import ButtonNormal from './../../../components/commons/ButtonNormal/index'
import { useDispatch, useSelector } from 'react-redux'
import {
  selectModifyStyles,
  resetState,
  setAppSize,
  setFontSize,
  setBrightness
} from './../../../features/ModifyStyles/modifyStylesSlice'
import { selectTheme, toggleTheme } from './../../../features/Theme/themeSlice'

const Setting = () => {
  const theme = useSelector(selectTheme)
  const modifyStyles = useSelector(selectModifyStyles)
  const dispatch = useDispatch()

  const [appSizeC, setAppSizeC] = useState()
  const [fontSizeC, setFontSizeC] = useState()
  const [brightnessC, setBrightnessC] = useState()

  const applyButtonHandle = () => {
    dispatch(setAppSize(appSizeC))
    dispatch(setFontSize(fontSizeC))
    dispatch(setBrightness(brightnessC))
  }
  const defaultButtonHandle = () => {
    dispatch(resetState())
    !theme.isLightTheme && dispatch(toggleTheme())
  }

  return (
    <Container>
      <Wrapper>
        <RangeModifiedArea>
          <TableBody>
            <Item>
              <Name>{Params.Range.appSize.name}</Name>
              <Content>
                {Params.Range.appSize.min}
                {Params.Range.unit}
                <RangeSliders
                  width={Params.Range.width}
                  min={Params.Range.appSize.min}
                  max={Params.Range.appSize.max}
                  value={modifyStyles.appSize}
                  enableTooltip
                  unit={Params.Range.unit}
                  onChangeHandle={value => setAppSizeC(prev => (prev = value))}
                />
                {Params.Range.appSize.max}
                {Params.Range.unit}
              </Content>
            </Item>
            <Item>
              <Name>{Params.Range.fontSize.name}</Name>
              <Content>
                {Params.Range.fontSize.min}
                {Params.Range.unit}
                <RangeSliders
                  width={Params.Range.width}
                  min={Params.Range.fontSize.min}
                  max={Params.Range.fontSize.max}
                  value={modifyStyles.fontSize}
                  enableTooltip
                  unit={Params.Range.unit}
                  onChangeHandle={value => setFontSizeC(prev => (prev = value))}
                />
                {Params.Range.fontSize.max}
                {Params.Range.unit}
              </Content>
            </Item>
            <Item>
              <Name>{Params.Range.brightness.name}</Name>
              <Content>
                {Params.Range.brightness.min}
                {Params.Range.unit}
                <RangeSliders
                  width={Params.Range.width}
                  min={Params.Range.brightness.min}
                  max={Params.Range.brightness.max}
                  value={modifyStyles.brightness}
                  enableTooltip
                  unit={Params.Range.unit}
                  onChangeHandle={value =>
                    setBrightnessC(prev => (prev = value))
                  }
                />
                {Params.Range.brightness.max}
                {Params.Range.unit}
              </Content>
            </Item>
            <Item>
              <Name>{Params.ToggleThemeButton.name}</Name>
              <Content>
                {Params.ToggleThemeButton.values.val1}
                <ButtonToggle
                  size={Params.ToggleThemeButton.size}
                  icon1={Params.ToggleThemeButton.icon.type1}
                  icon2={Params.ToggleThemeButton.icon.type2}
                  isLeft={theme.isLightTheme}
                  onClickHandle={() => dispatch(toggleTheme())}
                />
                {Params.ToggleThemeButton.values.val2}
              </Content>
            </Item>
          </TableBody>
        </RangeModifiedArea>
        <ControlArea>
          <ButtonNormal
            text={Params.ButtonNormal.name.default}
            size={Params.ButtonNormal.size}
            onClick={defaultButtonHandle}
          />
          <ButtonNormal
            text={Params.ButtonNormal.name.apply}
            size={Params.ButtonNormal.size}
            onClick={applyButtonHandle}
          />
        </ControlArea>
      </Wrapper>
    </Container>
  )
}

export default Setting
