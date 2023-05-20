import pytest

from dartcalc.score import calc
from dartcalc.score import checkout


@pytest.mark.parametrize(
    "entered,expected",
    [
        ("", 0),
        ("1 17", 17),
        ("1 17 1 3", 20),
        ("1 17 1 3 1 10", 30),
        ("2 17 1 3 1 10", 47),
    ],
)
def test_calc(entered, expected):
    assert calc(entered) == expected


@pytest.mark.parametrize(
    "score,expected",
    [
        (500, ""),
        (499, "2 1"),
        (461, "2 20"),
        (467, "2 17"),
        (489, "2 6"),
        (301, ""),
    ],
)
def test_checkout(score, expected):
    assert checkout(score) == expected
