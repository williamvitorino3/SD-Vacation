import Vue from 'vue'
import Router from 'vue-router'
import Home from '../components/Home'
import Notas from '../components/Notas'
import Fumante from '../components/Fumante'
import Numeros from '../components/Numeros'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'Home',
      component: Home
    },
    {
      path: '/notas',
      name: 'Notas',
      component: Notas
    },
    {
      path: '/fumante',
      name: 'Fumante',
      component: Fumante
    },
    {
      path: '/numeros',
      name: 'Numeros',
      component: Numeros
    }
  ]
})
