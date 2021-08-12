import { all, fork, put, takeLeading } from 'redux-saga/effects'
import { resetStateWhenLogout } from './resetStateSlice'
import { resetState as resetLoading } from '../Loading/loadingSlice'
import { resetState as resetAlert } from '../Alert/alertSlice'
import { resetState as resetDataCollection } from '../DataCollection/dataCollectionSlice'

function * workResetStateWhenLogout (action) {
  yield put(resetLoading())
  yield put(resetAlert())
  yield put(resetDataCollection())
}

function * watchResetStateWhenLogout (action) {
  yield takeLeading(resetStateWhenLogout.type, workResetStateWhenLogout)
}
function * resetAllStateSaga () {
  yield all([fork(watchResetStateWhenLogout)])
}

export default resetAllStateSaga
