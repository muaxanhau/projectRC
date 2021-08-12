import { createSlice } from '@reduxjs/toolkit'

const initialState = {}

export const resetStateSlice = createSlice({
  name: 'resetAllState',
  initialState,
  reducers: {
    resetAllState: state => {
      localStorage.clear()
    },
    resetStateWhenLogout: state => {
      localStorage.removeItem('token')
      localStorage.removeItem('itemsDraft')
    }
  }
})

export const { resetAllState, resetStateWhenLogout } = resetStateSlice.actions

export const selectResetAllState = state => state.resetAllState.value

export default resetStateSlice.reducer
