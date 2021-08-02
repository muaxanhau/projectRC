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
    resetLoadingState: state => {
      return initialState
    },
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

export const { resetLoadingState, loadingOn, loadingOff } = loadingSlice.actions

export const selectLoading = state => state.loading.value

export default loadingSlice.reducer
