import React, { useState } from 'react'
import { Params } from './defaultValue'
import {
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
    <Wrapper>
      <RangeModifiedArea>
        <TableBody>
          <Item>
            <Name>{Params.Range.name.appSize}</Name>
            <Content>
              <p>
                {Params.Range.min}
                {Params.Range.unit}
              </p>
              <RangeSliders
                width={Params.Range.width}
                min={Params.Range.min}
                max={Params.Range.max}
                value={modifyStyles.appSize}
                enableTooltip
                unit={Params.Range.unit}
                onChangeHandle={val => setAppSizeC(prev => (prev = val))}
              />
              <p>
                {Params.Range.max}
                {Params.Range.unit}
              </p>
            </Content>
          </Item>
          <Item>
            <Name>{Params.Range.name.fontSize}</Name>
            <Content>
              <p>
                {Params.Range.min}
                {Params.Range.unit}
              </p>
              <RangeSliders
                width={Params.Range.width}
                min={Params.Range.min}
                max={Params.Range.max}
                value={modifyStyles.fontSize}
                enableTooltip
                unit={Params.Range.unit}
                onChangeHandle={val => setFontSizeC(prev => (prev = val))}
              />
              <p>
                {Params.Range.max}
                {Params.Range.unit}
              </p>
            </Content>
          </Item>
          <Item>
            <Name>{Params.Range.name.brightness}</Name>
            <Content>
              <p>
                {Params.Range.min}
                {Params.Range.unit}
              </p>
              <RangeSliders
                width={Params.Range.width}
                min={Params.Range.min}
                max={Params.Range.max}
                value={modifyStyles.brightness}
                enableTooltip
                unit={Params.Range.unit}
                onChangeHandle={val => setBrightnessC(prev => (prev = val))}
              />
              <p>
                {Params.Range.max}
                {Params.Range.unit}
              </p>
            </Content>
          </Item>
          <Item>
            <Name>{Params.Range.name.theme}</Name>
            <Content>
              <p>Sáng</p>
              <ButtonToggle
                size={Params.ToggleThemeButton.size}
                icon1={Params.ToggleThemeButton.icon.type1}
                icon2={Params.ToggleThemeButton.icon.type2}
                isLeft={theme.isLightTheme}
                tooltip={Params.ToggleThemeButton.tooltip}
                onClickHandle={() => dispatch(toggleTheme())}
              />
              <p>Tối</p>
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
  )
}

export default Setting
