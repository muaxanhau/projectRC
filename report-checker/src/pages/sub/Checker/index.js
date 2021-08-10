import React, { useState } from 'react'
import { Params } from './defaultValue'
import {
  Wrapper,
  ContentLeft,
  MainContent,
  ControlLeftArea,
  ContentRight,
  ControlRightArea
} from './elements'
import ButtonNormal from './../../../components/commons/ButtonNormal/index'
import ButtonIcon from './../../../components/commons/ButtonIcon/index'
import Title from './../../../components/commons/Title/index'
import RadioButton from './../../../components/commons/RadioButton/index'
import InputTextarea from './../../../components/commons/InputTextarea/index'
import DataTable from './../../../components/commons/DataTable/index'
import DisplayRawData from './../../../components/DisplayRawData/index'
import StoreData from './../../../features/StoreData/index'
import { useDispatch, useSelector } from 'react-redux'
import { loadingOn, loadingOff } from './../../../features/Loading/loadingSlice'
import { alertOn } from './../../../features/Alert/alertSlice'
import {
  addDataToItemTotals,
  clearItemTotals,
  undoItemTotals,
  redoItemTotals,
  selectDataCollection
} from './../../../features/DataCollection/dataCollectionSlice'
import dataApi from './../../../api/dataApi'

const Checker = () => {
  const dispatch = useDispatch()
  const dataCollection = useSelector(selectDataCollection)
  const [option, setOption] = useState()
  const [rawData, setRawData] = useState('')
  const [temporaryData, setTemporaryData] = useState([])
  const [isDisplayTemporaryData, setIsDisplayTemporaryData] = useState(false)
  const [isDisplayStoreData, setIsDisplayStoreData] = useState(false)

  const transformDataButtonHandle = () => {
    if (rawData.trim() === '' || rawData === null) {
      dispatch(alertOn({ text: 'Trống' }))
      return
    }

    dispatch(loadingOn({ text: 'Đang xử lí' }))
    dataApi
      .transform({ purestring: rawData, option: option })
      .then(respone => {
        setTemporaryData(prev => (prev = respone))
        setIsDisplayTemporaryData(prev => (prev = true))
      })
      .catch(e => dispatch(alertOn({ text: 'Không thành công' })))
      .finally(() => dispatch(loadingOff()))
  }
  const deleteRawDataButtonHandle = () => {
    setRawData(prev => (prev = ''))
  }
  const undoButtonHandle = () => {
    dispatch(undoItemTotals())
  }
  const redoButtonHandle = () => {
    dispatch(redoItemTotals())
  }
  const clearDataButtonHandle = () => {
    dispatch(clearItemTotals())
  }
  const storeDataButtonHandle = () => {
    if (!dataCollection.itemTotals.length) {
      dispatch(alertOn({ text: 'Trống' }))
      return
    }

    setIsDisplayStoreData(prev => (prev = true))
  }

  const okButtonDisplayTemporaryData = data => {
    setTemporaryData(prev => {
      prev = data
      dispatch(addDataToItemTotals({ items: prev }))
      return prev
    })

    setIsDisplayTemporaryData(prev => (prev = false))
  }
  const cancelButtonDisplayTemporaryData = () => {
    setIsDisplayTemporaryData(prev => (prev = false))
  }

  return (
    <>
      {isDisplayTemporaryData && (
        <DisplayRawData
          dataRaw={rawData}
          dataTable={temporaryData}
          okHandle={okButtonDisplayTemporaryData}
          cancelHandle={cancelButtonDisplayTemporaryData}
        />
      )}
      {isDisplayStoreData && (
        <StoreData
          okHandle={() => setIsDisplayStoreData(prev => (prev = false))}
          cancelHandle={() => setIsDisplayStoreData(prev => (prev = false))}
        />
      )}
      <Wrapper>
        <ContentLeft>
          <Title text={Params.Title.name.left} size={Params.Title.size} />
          <MainContent>
            <RadioButton
              data={Params.RadioButton.data}
              size={Params.ButtonNormal.size}
              width='100%'
              valueOnChange={value => {
                setOption(prev => (prev = value))
              }}
            />
            <InputTextarea
              width='100%'
              height='100%'
              value={rawData}
              onChange={p => setRawData(prev => (prev = p.target.value))}
            />
          </MainContent>
          <ControlLeftArea>
            <ButtonNormal
              text={Params.ButtonNormal.name.transform}
              size={Params.ButtonNormal.size}
              width='70%'
              onClick={transformDataButtonHandle}
            />
            <ButtonNormal
              text={Params.ButtonNormal.name.clear}
              size={Params.ButtonNormal.size}
              width='30%'
              onClick={deleteRawDataButtonHandle}
            />
          </ControlLeftArea>
        </ContentLeft>
        <ContentRight>
          <Title text={Params.Title.name.right} size={Params.Title.size} />
          <MainContent>
            <DataTable
              data={dataCollection.itemTotals}
              width='100%'
              height='100%'
            />
          </MainContent>
          <ControlRightArea>
            <ButtonIcon
              size={Params.ButtonIcon.size}
              icon={Params.ButtonIcon.undo.icon.normal}
              iconSelected={Params.ButtonIcon.undo.icon.selected}
              tooltip={Params.ButtonIcon.undo.tooltip}
              onClick={undoButtonHandle}
            />
            <ButtonIcon
              size={Params.ButtonIcon.size}
              icon={Params.ButtonIcon.redo.icon.normal}
              iconSelected={Params.ButtonIcon.redo.icon.selected}
              tooltip={Params.ButtonIcon.redo.tooltip}
              onClick={redoButtonHandle}
            />
            <ButtonNormal
              text={Params.ButtonNormal.name.clear}
              size={Params.ButtonNormal.size}
              onClick={clearDataButtonHandle}
            />
          </ControlRightArea>
          <ButtonNormal
            text={Params.ButtonNormal.name.store}
            size={Params.ButtonNormal.size}
            width='100%'
            onClick={storeDataButtonHandle}
          />
        </ContentRight>
      </Wrapper>
    </>
  )
}

export default Checker
