import { createSlice } from '@reduxjs/toolkit'

const initialState = {
  value: {
    text: '',
    isOn: false,
    okHandle: () => {},
    cancelHandle: () => {}
  },
  status: 'idle'
}

export const alertSlice = createSlice({
  name: 'alert',
  initialState,
  reducers: {
    resetState: state => {
      return initialState
    },
    alertOn: (state, action) => {
      const { text, okHandle, cancelHandle } = action.payload
      state.value.text = text
      state.value.okHandle = okHandle
      state.value.cancelHandle = cancelHandle
      state.value.isOn = true
    },
    alertOff: state => {
      state.value.isOn = false
    }
  }
})

export const { resetState, alertOn, alertOff } = alertSlice.actions

export const selectAlert = state => state.alert.value

export default alertSlice.reducer
