import { createSlice } from '@reduxjs/toolkit'

const initialState = {
  value: {
    appSize: 100,
    fontSize: 100,
    brightness: 100
  },

  status: 'idle'
}

export const modifyStylesSlice = createSlice({
  name: 'modifyStyles',
  initialState,
  reducers: {
    resetState: state => {
      return initialState
    },
    setAppSize: (state, action) => {
      if (!action.payload || isNaN(action.payload)) {
        return state
      }
      localStorage.setItem('appSize', action.payload)
      return {
        ...state,
        value: { ...state.value, appSize: parseInt(action.payload) }
      }
    },
    setFontSize: (state, action) => {
      if (!action.payload || isNaN(action.payload)) {
        return state
      }
      localStorage.setItem('fontSize', action.payload)
      return {
        ...state,
        value: { ...state.value, fontSize: parseInt(action.payload) }
      }
    },
    setBrightness: (state, action) => {
      if (!action.payload || isNaN(action.payload)) {
        return state
      }
      localStorage.setItem('brightness', action.payload)
      return {
        ...state,
        value: { ...state.value, brightness: parseInt(action.payload) }
      }
    }
  }
})

export const {
  resetState,
  setAppSize,
  setFontSize,
  setBrightness
} = modifyStylesSlice.actions

export const selectModifyStyles = state => state.modifyStyles.value

export default modifyStylesSlice.reducer
