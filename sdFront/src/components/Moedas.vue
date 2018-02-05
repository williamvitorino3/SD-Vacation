<template>
  <app>
    <div class="container-fluid">
      <div class="row">
        <div class="offset-md-2 offset-lg-2 col-md-8 col-lg-8">
          <label for="">Cédula:</label>
          <input type="number" class="form-control" v-model="cedula" />
        </div>
      </div>
      <div class="row">
        <div class="offset-md-2 offset-lg-2 col-md-8 col-lg-8">
          <button class="btn" @click="post">Calcular</button>
        </div>
      </div>
      <div class="row">
        <div class="offset-md-2 offset-lg-2 col-md-8 col-lg-8">
          <table v-if="situacao.length" class="table table-dark">
        <thead>
          <tr>
            <th scope="col">Valor:</th>
            <th scope="col">50 c</th>
            <th scope="col">25 c</th>
            <th scope="col">10 c</th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <th scope="row">Quantidade:</th>
            <td>{{situacao[0]}}</td>
            <td>{{situacao[1]}}</td>
            <td>{{situacao[2]}}</td>
          </tr>
        </tbody>
      </table>
        </div>
      </div>
    </div>
  </app>
</template>

<script>
import appMenu from './Menu.vue';
export default {
  components: {
    app: appMenu,
  },
  data () {
    return {
      cedula: 0.0,
      situacao: '',
    }
  },
  methods: {
    post() {
      this.$http.post('http://localhost:5000/api/moedas', this.cedula).then(
        success => {
          this.situacao = success.body;
          // console.log(success);
        },
        err => {
          // console.log(err);
        }
      )
    }
  }
}
</script>

<style scoped>

</style>
