<template>
  <div class="container-fluid">
    <div class="row ">
      <h1 class="text-center">Notas</h1>
    </div>
      <div class="form-group">
        <input type="number" class="form-control" v-model="n1" />
      </div>
      <div class="form-group">
        <input class="form-control" v-model="n2" />
      </div>
      <div class="form-group">
        <button class="btn" @click="post">Calcular</button>
      </div>
    <p v-if="situacao.length">{{situacao}}</p>
  </div>
</template>

<script>
export default {
  data () {
    return {
      n1: 0,
      n2: 0,
      situacao: '',
    }
  },
  methods: {
    post() {
      this.$http.post('http://localhost:5000/api/notas', [this.n1, this.n2]).then(
        success => {
          this.situacao = success.bodyText;
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
