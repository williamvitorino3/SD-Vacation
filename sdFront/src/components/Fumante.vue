<template>
  <div class="container-fluid">
    <div class="row">
      <div class="offset-md-2 offset-lg-2 col-md-8 col-lg-8">
        <div class="form-group">
          <label for="anos">Anos que fuma: </label>
          <input name="anos" type="number" class="form-control" v-model="anos">
        </div>
      </div>
    </div>
    <div class="row">
      <div class="offset-md-2 offset-lg-2 col-md-8 col-lg-8">
        <div class="form-group">
          <label for="">Cigarros por dia:</label>
          <input type="number" class="form-control" v-model="cigarros">
        </div>
      </div>
    </div>
    <div class="row">
      <div class="offset-md-2 offset-lg-2 col-md-8 col-lg-8">
        <div class="form-group">
          <label for="">Preço da carteira:</label>
          <div class="input-group-prepend">
            <span class="input-group-text">$</span>
          </div>
          <input type="number" class="form-control" v-model="carteira">
        </div>
      </div>
    </div>
    <div class="row">
      <div class="offset-md-2 offset-lg-2 col-md-8 col-lg-8">
        <div class="form-group">
        <button class="btn" @click="post">Calcular</button>
        </div>
      </div>
    </div>
    <p class="text-center" v-if="situacao.length">R$ {{situacao}}</p>
  </div>
</template>

<script>
export default {
  data () {
    return {
      anos: 0,
      cigarros: 0,
      carteira: 0,
      situacao: '',
    }
  },
  methods: {
    post() {
      this.$http.post('http://localhost:5000/api/fumante', [this.anos, this.cigarros, this.carteira]).then(
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
