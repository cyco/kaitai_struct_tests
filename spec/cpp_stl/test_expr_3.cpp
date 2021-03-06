#include <boost/test/unit_test.hpp>

#include <expr_3.h>

#include <iostream>
#include <fstream>
#include <vector>

BOOST_AUTO_TEST_CASE(test_expr_3) {
    std::ifstream ifs("src/fixed_struct.bin", std::ifstream::binary);
    kaitai::kstream ks(&ifs);
    expr_3_t* r = new expr_3_t(&ks);

    BOOST_CHECK_EQUAL(r->one(), 80);
    BOOST_CHECK_EQUAL(r->two(), "ACK");

    BOOST_CHECK_EQUAL(r->three(), "@ACK");
    BOOST_CHECK_EQUAL(r->four(), "_ACK_");
    BOOST_CHECK_EQUAL(r->is_str_eq(), true);
    BOOST_CHECK_EQUAL(r->is_str_ne(), false);
    BOOST_CHECK_EQUAL(r->is_str_lt(), true);
    BOOST_CHECK_EQUAL(r->is_str_gt(), false);
    BOOST_CHECK_EQUAL(r->is_str_le(), true);
    BOOST_CHECK_EQUAL(r->is_str_ge(), false);
    BOOST_CHECK_EQUAL(r->is_str_lt2(), true);
    BOOST_CHECK_EQUAL(r->test_not(), true);

    delete r;
}
