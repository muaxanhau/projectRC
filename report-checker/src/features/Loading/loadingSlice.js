import { createSlice } from '@reduxjs/toolkit'

const initialState = {
  value: {
    text: '',
    isOn: false
  },
  status: 'idle'
}

export const loadingSlice = createSlice({
  name: 'loading',
  initialState,
  reducers: {
    loadingOn: (state, action) => {
      const { text } = action.payload
      state.value.text = text
      state.value.isOn = true
    },
    loadingOff: state => {
      state.value.isOn = false
    }
  }
})

export const { loadingOn, loadingOff } = loadingSlice.actions

export const selectLoading = state => state.loading.value

export default loadingSlice.reducer
