import { all, fork, put, takeLeading } from 'redux-saga/effects'
import { resetRedux } from './resetAllStateSlice'
import { resetLoadingState } from './../Loading/loadingSlice'
import { resetAlertState } from './../Alert/alertSlice'
import { resetDataCollectionState } from './../DataCollection/dataCollectionSlice'

function * workResetAllState (action) {
  yield put(resetLoadingState())
  yield put(resetAlertState())
  yield put(resetDataCollectionState())
}

function * watchResetAllState (action) {
  yield takeLeading(resetRedux.type, workResetAllState)
}
function * resetAllStateSaga () {
  yield all([fork(watchResetAllState)])
}

export default resetAllStateSaga
