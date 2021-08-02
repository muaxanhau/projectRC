import { createSlice } from '@reduxjs/toolkit'

const initialState = {}

export const resetAllStateSlice = createSlice({
  name: 'resetAllState',
  initialState,
  reducers: {
    resetRedux: state => {}
  }
})

export const { resetRedux } = resetAllStateSlice.actions

export const selectResetAllState = state => state.resetAllState.value

export default resetAllStateSlice.reducer
